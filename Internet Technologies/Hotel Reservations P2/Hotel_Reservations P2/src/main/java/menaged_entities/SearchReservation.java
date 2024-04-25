package menaged_entities;

import java.util.ArrayList;
import java.util.List;

import dao.Database;
import entities.Reservation;
import jakarta.annotation.PostConstruct;
import jakarta.ejb.EJB;
import jakarta.enterprise.context.RequestScoped;

import jakarta.inject.Named;

@Named
@RequestScoped
public class SearchReservation {
    private String searchName;
    private List<Reservation> searchResults;
    private List<Reservation> allReservations;
    
    @EJB
    Database db;
    
    @PostConstruct
    public void init() {
        allReservations = db.returnReservations();
    }

    public List<Reservation> getAllReservations() {
        return allReservations;
    }
    
    public String getSearchName() {
        return searchName;
    }

    public void setSearchName(String searchName) {
        this.searchName = searchName;
    }

    public List<Reservation> getSearchResults() {
        return searchResults;
    }

    public void setSearchResults(List<Reservation> searchResults) {
        this.searchResults = searchResults;
    }
    
    public String search() {
        if (searchName != null && !searchName.trim().isEmpty()) {
            searchResults = new ArrayList<>();
            for (Reservation reservation : db.returnReservations() ) {
                if (reservation.getName().toLowerCase().contains(searchName.trim().toLowerCase())) {
                    searchResults.add(reservation);
                }
            }
        } else {
            searchResults = null;
        }
        return null;
    }

    public void allReservations() {
    	db.returnReservations();
    }

    public String show() {
    	searchResults = new ArrayList<>();
    	for (Reservation reservation : db.returnReservations() ) {
    		searchResults.add(reservation);
	    }
    	return null;
    }

}
