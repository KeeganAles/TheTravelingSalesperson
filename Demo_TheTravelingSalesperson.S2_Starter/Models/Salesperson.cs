﻿using System.Collections.Generic;

namespace Demo_TheTravelingSalesperson
{
    /// <summary>
    /// Salesperson MVC Model class
    /// </summary>
    class Salesperson
    {
        #region FIELDS

        private string _firstName;
        private string _lastName;
        private string _accountID;
        private List<string> _citiesVisited;

        private Product _currentStock;

        #endregion

        #region PROPERTIES

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string AccountID
        {
            get { return _accountID; }
            set { _accountID = value; }
        }

        public List<string> CitiesVisited
        {
            get { return _citiesVisited; }
            set { _citiesVisited = value; }
        }

        public Product CurrentStock
        {
            get { return _currentStock; }
            set { _currentStock = value; }
        }

        #endregion

        #region CONSTRUCTORS

        public Salesperson()
        {
            _citiesVisited = new List<string>();
            _currentStock = new Product();
        }

        public Salesperson(string firstName, string lastName, string accountID)
        {
            _firstName = firstName;
            _lastName = lastName;
            _accountID = accountID;

            _citiesVisited = new List<string>();
            _currentStock = new Product();
        }

        #endregion
        
        #region METHODS



        #endregion
    }
}
