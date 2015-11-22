package opg2.entities;

public class Address {

	private int id;
	private String address1;
	private String address2;
	private String PostalCode;
	private String City;
	private String State;
	private String Country;
	
	public Address(String address1, String address2, String postalCode, String city, String state, String country) {
		this.address1 = address1;
		this.address2 = address2;
		PostalCode = postalCode;
		City = city;
		State = state;
		Country = country;
	}

	public int getId() {
		return id;
	}
	
	public void setId(int id) {
		this.id = id;
	}
	
	public String getAddress1() {
		return address1;
	}

	public void setAddress1(String address1) {
		this.address1 = address1;
	}

	public String getAddress2() {
		return address2;
	}

	public void setAddress2(String address2) {
		this.address2 = address2;
	}

	public String getPostalCode() {
		return PostalCode;
	}

	public void setPostalCode(String postalCode) {
		PostalCode = postalCode;
	}

	public String getCity() {
		return City;
	}

	public void setCity(String city) {
		City = city;
	}

	public String getState() {
		return State;
	}

	public void setState(String state) {
		State = state;
	}

	public String getCountry() {
		return Country;
	}

	public void setCountry(String country) {
		Country = country;
	}
	
}
