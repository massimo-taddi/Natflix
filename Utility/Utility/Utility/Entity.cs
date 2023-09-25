using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Utility
{
    public class Entity
    {
        public Entity() { }
        public Entity (int id) 
        {
            Id = id;
        }
        public int Id {  get; set; }
    
        public string Tostring()
        {
            string ris = "";
            //serve per restituire una raccolta di oggetti con nome della proprietà e valore
            foreach(PropertyInfo proprieta in this.GetType().GetProperties())
            {
                ris += $"{proprieta.Name} : {proprieta.GetValue(this)}\n";
            }
            return ris;
        }
        // ciò per cui viene utilizzato questo metodo è per tradurre i dati presi
        // tramite dictionary da un db sql in dati utilizzabili su visual
        public void FromDictionary(Dictionary<string, string> riga)
        {
            foreach (PropertyInfo proprieta in this.GetType().GetProperties())
            {
                if (riga.ContainsKey(proprieta.Name.ToLower()))
                {
                    object valore = riga[proprieta.Name.ToLower()];
                    switch(proprieta.PropertyType.Name.ToLower()) 
                    {
                        case "int32":
                            valore = int.Parse(riga[proprieta.Name.ToLower()]);
                            break;
                        case "double":
                            valore = double.Parse(riga[proprieta.Name.ToLower()]);
                            break;
                        case "bool":
                        case "boolean":
                             string bitValue = riga[proprieta.Name.ToLower()];
                             bool booleanValue = false;
                             if (bitValue=="1"|| bitValue.Equals("true",StringComparison.OrdinalIgnoreCase))
                             {
                                booleanValue=true;
                             }
                            valore = booleanValue;
                            break;

                        case "datatime":
                            valore = DateTime.Parse(riga[proprieta.Name.ToLower()]);
                            break;
                       
                    }
                    proprieta.SetValue(this,valore);
                }
            }
        }
    }
}
