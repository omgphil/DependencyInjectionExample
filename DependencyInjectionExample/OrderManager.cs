﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionExample
{
    public interface IOrderManager
    {
        void Submit(Product product, string creditCardNumber, string expiryDate);
    }
    public class OrderManager : IOrderManager
    {
        private readonly IProductStockRepository _productStockRepository;
        private readonly IPaymentProcessor _paymentProcessor;
        private readonly IShippingProcessor _shippingProcessor;

        public OrderManager(IProductStockRepository productStockRepository, IPaymentProcessor paymentProcessor, IShippingProcessor shippingProcessor)
        {
            _productStockRepository = productStockRepository;
            _paymentProcessor = paymentProcessor;
            _shippingProcessor = shippingProcessor;
        }
        public void Submit(Product product, string creditCardNumber, string expiryDate)
        {

            // Check product stock
            if (!_productStockRepository.isInStock(product))
            {
                throw new Exception($"{product.ToString()} currently not in stock");
            }

            // payment
            _paymentProcessor.ChargeCreditCard(creditCardNumber, expiryDate);

            // ship 

            _shippingProcessor.MailProduct(product);
        }
    }
}
