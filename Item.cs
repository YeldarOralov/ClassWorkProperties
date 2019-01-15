using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesLession
{
    public class Item
    {
        //autoproperty (автосвойство)
        //public возвр_тип Название { мод_доступа get; мод_доступа set; }

        public int Id { get; set; }

        //property (свойство)
        //public возвр_тип Название {
        //      мод_доступа get {
        //           тело;
        //           return переменная;
        //      }
        //      мод_доступа set {
        //           тело;
        //           переменная = value;
        //      }
        // }

        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public double Price { get; set; }

        public DateTime CreationDate { get; private set; }
        public DateTime[] ChangedDates { get; set; }
        public DateTime this[int index]
        {
            get
            {
                return ChangedDates[index];
            }
            set
            {
                ChangedDates[index] = value;
            }
        }


        public Item()
        {
            CreationDate = DateTime.Now;
        }



        /*private int _id;
        private string _name;
        private double _price;

        public int GetId()
        {
            return _id;
        }
        public void SetId(int id)
        {
            _id = id;
        }
        */
    }
}
