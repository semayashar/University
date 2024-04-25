package menaged_entities;

import java.util.ArrayList;
import java.util.List;

import dao.Database;
import entities.Reservation;
import jakarta.enterprise.context.RequestScoped;
import jakarta.inject.Inject;
import jakarta.inject.Named;

@Named
@RequestScoped
public class SearchReservation {
    private String searchName;
    private List<Reservation> searchResults;

    @Inject
    private Database database;

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
            for (Reservation reservation : database.getReservations()) {
                if (reservation.getName().toLowerCase().contains(searchName.trim().toLowerCase())) {
                    searchResults.add(reservation);
                }
            }
        } else {
            searchResults = null;
        }
        return null;
    }
    

}
