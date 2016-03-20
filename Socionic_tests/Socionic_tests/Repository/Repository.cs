using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Socionic_tests.Model;

namespace Socionic_tests.Repository
{
    class Repository
    {
        private int _countTestPoints;

        public int CountTestPoints
        {
            get { return _countTestPoints; }
            set { _countTestPoints = value; }
        }
        ICollection<UserDataItem> _users = new List<UserDataItem>();
        
    }
}
