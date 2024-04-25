package dao;

import java.util.ArrayList;
import entities.Reservation;
import jakarta.enterprise.context.ApplicationScoped;
import jakarta.inject.Named;

@Named
@ApplicationScoped
public class Database {
    private ArrayList<Reservation> reservations = new ArrayList<Reservation>();

    // Initialize with some sample data
    public Database() {
        reservations.add(new Reservation(1, "John Doe", "2024-04-20", "2024-04-25", "Single", true, false, 100.0));
        reservations.add(new Reservation(2, "Jane Smith", "2024-05-01", "2024-05-10", "Double", false, true, 150.0));
    }

    public ArrayList<Reservation> getReservations() {
        return reservations;
    }

    public void addReservation(Reservation rsv) {
        reservations.add(rsv);
    }
    
    public void deleteReservation(Reservation reservation) {
        System.out.println("Before deletion: " + reservations);
        reservations.remove(reservation);
        System.out.println("After deletion: " + reservations);
    }
    
   
}
