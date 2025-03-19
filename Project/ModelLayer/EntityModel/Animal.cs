using System;

namespace Project.ModelLayer.EntityModel
{
    public class Animal
    {
        public string Id { get; set; }
        public int Tipo { get; set; }

        public Animal()
        {
            Id = "";
            Tipo = -1;
        }

        public Animal(string id, int tipo)
        {
            Id = id;
            Tipo = tipo;
        }
    }
}