package menaged_entities;


import dao.Database;
import entities.IdGenerator;
import entities.Reservation;
import jakarta.enterprise.context.RequestScoped;
import jakarta.inject.Inject;
import jakarta.inject.Named;

@Named
@RequestScoped
public class Reservations {
	private int id;
    private String name;
    private String arrivalDate;
    private String departureDate;
    private String apartmentType;
    private boolean breakfast;
    private boolean dinner;
    private double price;
    
    @Inject
    private Database database;
    
    // Getters and setters

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public String getArrivalDate() {
        return arrivalDate;
    }

    public void setArrivalDate(String arrivalDate) {
        this.arrivalDate = arrivalDate;
    }

    public String getDepartureDate() {
        return departureDate;
    }

    public void setDepartureDate(String departureDate) {
        this.departureDate = departureDate;
    }

    public String getApartmentType() {
        return apartmentType;
    }

    public void setApartmentType(String apartmentType) {
        this.apartmentType = apartmentType;
    }

    public boolean isBreakfast() {
        return breakfast;
    }

    public void setBreakfast(boolean breakfast) {
        this.breakfast = breakfast;
    }

    public boolean isDinner() {
        return dinner;
    }

    public void setDinner(boolean dinner) {
        this.dinner = dinner;
    }

    public double getPrice() {
        return price;
    }

    public void setPrice(double price) {
        this.price = price;
    }
    
    public int getId() {
		return id;
	}

	public void setId(int id) {
		this.id = id;
	}

    public String send() {
        // Check if all required fields are filled
        if (name != null && arrivalDate != null && departureDate != null && price > 0 && apartmentType != null) {
            int newId = IdGenerator.generateId();
            Reservation reservation = new Reservation(newId, name, arrivalDate, departureDate, apartmentType, breakfast,
                    dinner, price);

            // Call the addReservation method on the injected Database instance
            database.addReservation(reservation);
            return "sent";
        } else {
            // If any required field is missing, return an error message or handle it as appropriate
            return "contacts"; // You can modify this to return a specific error message or handle it differently
        }
    }

	
}
