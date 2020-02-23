using DatabaseLibrary.Core;
using DatabaseLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Net;
using System.Text;

namespace DatabaseLibrary.Helpers
{
    public class StudentHelper_db
    {

        /// <summary>
        /// Adds a new instance into the database.
        /// </summary>
        public static Student_db Add(string firstName, string lastName,
            DbContext context, out StatusResponse statusResponse)
        {
            try
            {
                // Validate
                if (string.IsNullOrEmpty(firstName?.Trim()))
                    throw new StatusException(HttpStatusCode.BadRequest, "Please provide a first name.");
                if (string.IsNullOrEmpty(lastName?.Trim()))
                    throw new StatusException(HttpStatusCode.BadRequest, "Please provide a last name.");

                // Generate a new instance
                Student_db instance = new Student_db
                    (
                        id: Guid.NewGuid().ToString(),
                        firstName, lastName
                    );

                // Add to database
                int rowsAffected = context.ExecuteNonQueryCommand
                    (
                        commandText: "INSERT INTO `student` (id, first_name, last_name) values (@id, @first_name, @last_name)",
                        parameters: new Dictionary<string, object>()
                        {
                            { "@id", instance.Id },
                            { "@first_name", instance.FirstName },
                            { "@last_name", instance.LastName }
                        },
                        message: out string message
                    );
                if (rowsAffected == -1)
                    throw new Exception(message);

                // Return value
                statusResponse = new StatusResponse("Student added successfully");
                return instance;
            }
            catch (Exception exception)
            {
                statusResponse = new StatusResponse(exception);
                return null;
            }
        }

    }
}
