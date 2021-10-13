using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opdracht3
{
    internal class Stapel<T>
    {
            public List<T> myStapel;

            public Stapel()
            {
                myStapel = new List<T>();
            }
            public void Toevoegen(T item)
            {
                myStapel.Add(item);

            }
            public T Verwijderen()
            {
                try
                {
                    myStapel.RemoveAt(myStapel.Count - 1);

                }
                catch (ArgumentOutOfRangeException)
                {
                    MessageBox.Show("Geen item om te verwijderen", "Error");
                }


                return myStapel.LastOrDefault();
            }
            public void Leegmaken()
            {

                myStapel.Clear();
            }
            public Boolean isAanwezig(T item)
            {

            if (myStapel.Contains(item) == true)
            {
                return true;
            }
            else return false;
            }

            public override string ToString()
            {


                return string.Join(",", myStapel);
        }
    }
}
