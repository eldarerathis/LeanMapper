﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeanMapper.Tests
{
    [TestClass]
    public class MappingEntityWithOnlyPrimitives
    {
        #region Classes

        public class Customer
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public decimal Credit { get; set; }
            public bool IsActive { get; set; }
            public char DriverLicenceType { get; set; }
            public double? Debit { get; set; }
            public string City { get; set; }
            public string Country { get; set; }
        }

        public class CustomerDTO
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public decimal Credit { get; set; }
            public bool IsActive { get; set; }
            public char DriverLicenceType { get; set; }
            public double? Debit { get; set; }
        }

        public Customer GetCustomer()
        {
            return new Customer()
            {
                City = "istanbul",
                Country = "turkey",
                Credit = 1542,
                DriverLicenceType = 'B',
                Id = 1,
                Debit = 100,
                IsActive = true,
                Name = "Timuçin"
            };
        }

        #endregion

        [TestMethod]
        public void ConvertPrimitiveEntityToDto()
        {
            var dto = LeanMapper.Map<Customer, CustomerDTO>(GetCustomer());
            
            Assert.IsNotNull(dto);
            Assert.IsTrue(dto.Id == 1 && 
                dto.Name == "Timuçin" && 
                dto.Credit == 1542 &&
                dto.IsActive &&
                dto.DriverLicenceType == 'B' &&
                dto.Debit == 100
                );
        }
    }
}
