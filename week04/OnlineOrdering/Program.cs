using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
        Console.WriteLine();



        Address address1 = new Address("morrison street", "Las Vegas", "Nevada", "usa");

        Customer customer1 = new Customer("Gary", address1);
        

        Product product1 = new Product("eggs", "eg1", 12.99, 2);
        Product product2 = new Product("bread", "br1", 10.99, 4);
        Product product3 = new Product("water", "wr1", 4.99, 2);
        Product product4 = new Product("steaks", "mt1", 20.99, 5);

        List<Product> products = new List<Product>();
        products.Add(product1);
        products.Add(product2);
        products.Add(product3);
        products.Add(product4);

        Order order1 = new Order(customer1, products);
        Console.WriteLine(order1.GetShipping());
        Console.WriteLine(order1.GetPackingLabel());

        Console.WriteLine($"Your Total: {order1.GetTotalCost()}");

        Address address2 = new Address("baker st", "paris", "n/a", "France");

        Customer customer2 = new Customer("Rachel",address2);


        Product order2product1 = new Product("juice", "ju1", 12.99, 2);
        Product order2product2 = new Product("bread", "br1", 10.99, 1);
        Product order2product3 = new Product("waffles", "wf1", 7.99, 2);
        Product order2product4 = new Product("chicken", "ck1", 24.99, 4);

        List<Product> order2products = new List<Product>();
        order2products.Add(order2product1);
        order2products.Add(order2product2);
        order2products.Add(order2product3);
        order2products.Add(order2product4);

        Order order2 = new Order(customer2, order2products);
        Console.WriteLine(order2.GetShipping());
        Console.WriteLine(order2.GetPackingLabel());

        Console.WriteLine($"Your Total: {order2.GetTotalCost()}");



    }

}