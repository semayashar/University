package menaged_entities;

import dao.Database;
import entities.Reservation;
import jakarta.ejb.EJB;
import jakarta.enterprise.context.RequestScoped;
import jakarta.inject.Named;

@Named
@RequestScoped
public class Reservations {
    
    @EJB
    Database db;

    private String name;
    private String arrivalDate;
    private String departureDate;
    private String apartmentType;
    private boolean breakfast;
    private boolean dinner;
    private double price;

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
    


    public String send() {
        if (name != null && arrivalDate != null && departureDate != null && price > 0 && apartmentType != null) {
            
        	Reservation reservation = new Reservation(name, arrivalDate, departureDate, apartmentType, breakfast, dinner, price);
            db.addReservation(reservation);
            return "sent";
        } 
        else {
            return "contacts"; 
        }
    }

	
}
