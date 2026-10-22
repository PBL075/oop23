using System;

namespace audi
{
    struct StructAudi
    {
        private string model;
        private int pretEuro;

        public void Caracteristici(string model , int pretEuro)
        {
            this.model = model;
            this.pretEuro = pretEuro;
             Console.WriteLine("Modelul la audi este "+ model + ". Iar pretul in euro este "+ pretEuro + " euro ");
        } 
        
        
           
    
        
    }
}