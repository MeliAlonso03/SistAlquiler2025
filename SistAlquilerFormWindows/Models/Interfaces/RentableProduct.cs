using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistAlquilerFormWindows.Models.Interfaces
{
    public abstract class RentableProduct
    {
        // Contador estático para generar IDs únicos
        private static int _nextId = 1;

        // Propiedad ID autoincrementable
        public int Id { get; }

        // Otras propiedades
        public string Name { get; protected set; }
        public DateTime DateTimeStart { get; protected set; }
        public DateTime EndDateTime { get; protected set; }
        public decimal PrecioxHora { get; protected set; }
        public decimal Precio { get; protected set; }
        public IPriceStrategy PriceStrategy { get; protected set; }

        // Constructor que asigna un ID único automáticamente
        protected RentableProduct(string name, DateTime dateTimeStart, DateTime endDateTime, decimal precioxHora, IPriceStrategy priceStrategy)
        {
            Id = _nextId++; // Asigna el ID y luego incrementa el contador
            Name = name;
            DateTimeStart = dateTimeStart;
            EndDateTime = endDateTime;
            PrecioxHora = precioxHora;
            PriceStrategy = priceStrategy;
        }

        // Métodos abstractos (deben ser implementados en las subclases)
        public abstract decimal CalcularPrecioAlquiler();
        public abstract void Rent();
        public abstract string GetDetails();
    }
}
