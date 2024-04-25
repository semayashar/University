package entities;

public class Reservation {
	private int id;
	private String name;
    private String arrivalDate;
    private String departureDate;
    private String apartmentType;
    private boolean breakfast;
    private boolean dinner;
    private double price;
    
  //CONSTRUCTORS
    
    public Reservation() {}
    
    public Reservation(int id, String name, String arrivalDate, String departureDate, String apartmentType,
			boolean breakfast, boolean dinner, double price) {
	
		this.id = id;
		this.name = name;
		this.arrivalDate = arrivalDate;
		this.departureDate = departureDate;
		this.apartmentType = apartmentType;
		this.breakfast = breakfast;
		this.dinner = dinner;
		this.price = price;
	}
    
    
	//GETTERS AND SETTERS
    
    
	public int getId() {
		return id;
	}
	public String getName() {
		return name;
	}
	public String getArrivalDate() {
		return arrivalDate;
	}
	public String getDepartureDate() {
		return departureDate;
	}
	public String getApartmentType() {
		return apartmentType;
	}
	public boolean isBreakfast() {
		return breakfast;
	}
	public boolean isDinner() {
		return dinner;
	}
	public double getPrice() {
		return price;
	}
	public void setId(int id) {
		this.id = id;
	}
	public void setName(String name) {
		this.name = name;
	}
	public void setArrivalDate(String arrivalDate) {
		this.arrivalDate = arrivalDate;
	}
	public void setDepartureDate(String departureDate) {
		this.departureDate = departureDate;
	}
	public void setApartmentType(String apartmentType) {
		this.apartmentType = apartmentType;
	}
	public void setBreakfast(boolean breakfast) {
		this.breakfast = breakfast;
	}
	public void setDinner(boolean dinner) {
		this.dinner = dinner;
	}
	public void setPrice(double price) {
		this.price = price;
	}

	@Override
	public String toString() {
		return "Reservation [id=" + id + ", name=" + name + ", arrivalDate=" + arrivalDate + ", departureDate="
				+ departureDate + ", apartmentType=" + apartmentType + ", breakfast=" + breakfast + ", dinner=" + dinner
				+ ", price=" + price + "]";
	}
	
    
}
