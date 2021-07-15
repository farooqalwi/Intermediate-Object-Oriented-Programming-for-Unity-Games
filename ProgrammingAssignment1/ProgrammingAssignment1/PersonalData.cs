using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingAssignment1
{
    /// <summary>
    /// A class holding personal data for a person
    /// </summary>
    public class PersonalData
    {
        #region Fields

        // declare your fields here
        string firstName;
        string middleName;
        string lastName;
        string streetAddress;
        string city;
        string state;
        string postalCode;
        string country;
        string phoneNumber;


        #endregion

        #region Properties

        /// <summary>
        /// Gets the person's first name
        /// </summary>
        public string FirstName
        {
            get 
            {
                return this.firstName;
            }
            set
            {
                this.firstName = value;
            }
        }

        /// <summary>
        /// Gets the person's middle name
        /// </summary>
        public string MiddleName
        {
            get
            {
                return this.middleName;
            }
            set
            {
                this.middleName = value;
            }
        }

        /// <summary>
        /// Gets the person's last name
        /// </summary>
        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                this.lastName = value;
            }
        }

        /// <summary>
        /// Gets the person's street address
        /// </summary>
        public string StreetAddress
        {
            get
            {
                return this.streetAddress;
            }
            set
            {
                this.streetAddress = value;
            }
        }

        /// <summary>
        /// Gets the person's city or town
        /// </summary>
        public string City
        {
            get
            {
                return this.city;
            }
            set
            {
                this.city = value;
            }
        }

        /// <summary>
        /// Gets the person's state or province
        /// </summary>
        public string State
        {
            get
            {
                return this.state;
            }
            set
            {
                this.state = value;
            }
        }

        /// <summary>
        /// Gets the person's postal code
        /// </summary>
        public string PostalCode
        {
            get
            {
                return this.postalCode;
            }
            set
            {
                this.postalCode = value;
            }
        }

        /// <summary>
        /// Gets the person's country
        /// </summary>
        public string Country
        {
            get
            {
                return this.country;
            }
            set
            {
                this.country = value;
            }
        }

        /// <summary>
        /// Gets the person's phone number (digits only, no 
        /// parentheses, spaces, or dashes)
        /// </summary>
        public string PhoneNumber
        {
            get
            {
                return this.phoneNumber;
            }
            set
            {
                this.phoneNumber = value;
            }
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor
        /// Reads personal data from a file. If the file
        /// read fails, the object contains an empty string for all
        /// the personal data
        /// </summary>
        /// <param name="fileName">name of file holding personal data</param>
        public PersonalData(string fileName)
        {
            // your code can assume we know the order in which the
            // values appear in the string; it's the same order as
            // they're listed for the properties above. We could do 
            // something more complicated with the names and values, 
            // but that's not necessary here

            if (File.Exists(fileName))
            {
                string text = System.IO.File.ReadAllText(fileName);
                List<string> list = new List<string>();

                var values = text.Split(',');
                foreach (var item in values)
                {
                    list.Add(item);
                }

                FirstName = list[0];
                MiddleName = list[1];
                LastName = list[2];
                StreetAddress = list[3];
                City = list[4];
                State = list[5];
                PostalCode = list[6];
                Country = list[7];
                PhoneNumber = list[8];
            }  



            // IMPORTANT: The mono compiler the automated grader uses
            // does NOT support the string Split method. You have to 
            // use the IndexOf method to find comma locations and the
            // Substring method to chop off the front of the string
            // after you extract each value to extract and save the
            // personal data
        }

        #endregion
    }
}
