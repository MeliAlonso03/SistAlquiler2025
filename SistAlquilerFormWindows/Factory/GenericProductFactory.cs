using SistAlquilerFormWindows.Models.Interfaces;
using SistAlquilerFormWindows.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistAlquilerFormWindows.Interfaces;

namespace SistAlquilerFormWindows.Factory
{
    public class GenericProductFactory : IProductFactory
    {
        private readonly Dictionary<Type, Func<string, DateTime, DateTime, decimal, IRentableObject, RentableProduct>> _registeredProducts =
        new Dictionary<Type, Func<string, DateTime, DateTime, decimal, IRentableObject, RentableProduct>>();

        public GenericProductFactory()
        {
            RegisterProduct<Car>((name, start, end, price, car) => new RentCar(name, start, end, price, car));
            RegisterProduct<WashingMachine>((name, start, end, price, washingMachine) => new RentWashingMachine(name, start, end, price, washingMachine));
        }

        public void RegisterProduct<T>(Func<string, DateTime, DateTime, decimal, T, RentableProduct> creator) where T : IRentableObject
        {
            _registeredProducts[typeof(T)] = (name, start, end, price, rentableObject) => creator(name, start, end, price, (T)rentableObject);
        }

        public RentableProduct CreateRent(string name, DateTime start, DateTime end, decimal price, IRentableObject rentableObject)
        {
            Console.WriteLine($"Intentando alquilar {rentableObject.GetType().Name} de {start} a {end}");
            if (!rentableObject.Rent(start, end))
            {
                throw new InvalidOperationException($"El objeto ya está alquilado desde {start} hasta {end}.");
            }

            if (_registeredProducts.TryGetValue(rentableObject.GetType(), out var creator))
            {
                return creator(name, start, end, price, rentableObject);
            }
            throw new ArgumentException("Tipo de objeto no soportado");
        }
    }
}
