using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Tutorials
{
    class Collections
    {
        int id;
        string name;
        string category;
        int rank;
        
        public int ID
        { 
            set
            {
                if(value <= 0)
                {
                    throw new Exception("Not accepted");
                }
                else
                {
                    this.id = value;
                }
            }
            get {
                return this.id;
                }

        }
        
        public string Name
        {
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new Exception("Not accepted");
                }
                else
                {
                    this.name = value;
                }
            }
            get
            {
                return this.name;
            }
        }
        public string Category
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Not accepted");
                }
                else
                {
                    this.category = value;
                }
            }
            get
            {
                return this.category;
            }
        }

        public int Rank
        {
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Not accepted");
                }
                else
                {
                    this.rank = value;
                }
            }
            get
            {
                return this.rank;
            }

        }
    }
    }

