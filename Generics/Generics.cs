using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generics
{
    public class Generics
    {
        private List<string> test;

        void myMethod()
        {
            //this is how you call a generic list
            SqlExecute<string>("[dbo].[MenuSelections_Insert] @Id, @Img", test);
        }

        public void SqlExecute<T>(string sql, List<T> data)
        {

        }

    }
}
