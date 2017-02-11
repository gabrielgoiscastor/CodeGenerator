﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator
{
    class Property
    {
        private string type;
        private string name;
        private bool isList;

        #region Properties
        public string Type
        {
            get
            {
                return type;
            }

            set
            {
                type = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public bool IsList
        {
            get
            {
                return isList;
            }

            set
            {
                isList = value;
            }
        }
        #endregion

        #region Constructor
        public Property() { }
        #endregion
    }
}
