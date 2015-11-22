package opg2.entities;

import java.util.Date;

public class Price {

	private int id;
	private double value;
	private String currency;
	/**
	 * The date from which this price is active.
	 */
	private Date fromDate;
	
	public Price(double value, String currency, Date fromDate) {
		this.value = value;
		this.currency = currency;
		this.fromDate = fromDate;
	}

	public int getId() {
		return id;
	}
	
	public void setId(int id) {
		this.id = id;
	}

	public double getValue() {
		return value;
	}

	public void setValue(double value) {
		this.value = value;
	}

	public String getCurrency() {
		return currency;
	}

	public void setCurrency(String currency) {
		this.currency = currency;
	}

	/**
	 * The date from which this price is active.
	 */
	public Date getDateFrom() {
		return fromDate;
	}

	/**
	 * The date from which this price is active.
	 */
	public void setDateFrom(Date dateFrom) {
		this.fromDate = dateFrom;
	}
	
	@Override
	public String toString() {
		return value + " " + currency + ", from: " + fromDate;
	}
	
}
