package opg2;

import java.util.Calendar;

import opg2.entities.Address;
import opg2.entities.Customer;
import opg2.entities.Order;
import opg2.entities.Price;
import opg2.entities.Producer;
import opg2.entities.Product;

public class Opg2Tester {

	public static void main(String[] args) {
		// Create a couple of products and an order.
		Producer producer1 = new Producer("Coalition of Nigaraguan Coffee Farmers", "This is the largest coalition of coffee farmers in Nigaragua,"
				+ " collectively producing more coffee than any producer of coffee in the world.");
		Product p1 = new Product("p1", "Coffee Nigaragua", "This is an amazingly delisious, but expensive coffee. Weight: 0.2KG", producer1);
		Calendar cal = Calendar.getInstance();
		cal.set(2015, 8, 22);
		p1.addPrice(new Price(100, "DKK", cal.getTime()));
		cal.set(2015, 11, 18);
		p1.addPrice(new Price(200, "DKK", cal.getTime()));
		
		Producer producer2 = new Producer("The Time Lord", "This mystical figure changes his face all the time. Therefore hard to describe.");
		Product p2 = new Product("p2", "Free time", "This mystical product only exists in limited quantities, Amount: 1 sec.", producer2);
		cal.set(2015, 11, 10);
		p2.addPrice(new Price(1, "DKK", cal.getTime()));
		cal.set(2015, 11, 11);
		p2.addPrice(new Price(Double.MAX_VALUE, "DKK", cal.getTime()));
		
		Address a1 = new Address("Someroad 23", "2F left", "1234", "Phoenixia", "", "Utopia");
		Customer c1 = new Customer("Mr", "Phillip", "Phoelich", a1, "12345678", "myemail@email.com");
		Order o1 = new Order(c1, "DKK", a1, Order.OrderStatus.UNSHIPPED);
		o1.addProduct(p1);
		o1.addProduct(p2);
		o1.addProduct(p2);
		o1.addProduct(p1);
		System.out.println(o1);
	}

}
