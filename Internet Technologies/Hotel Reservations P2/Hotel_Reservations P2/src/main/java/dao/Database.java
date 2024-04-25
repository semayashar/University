package dao;

import entities.Reservation;
import jakarta.ejb.Stateless;
import jakarta.persistence.EntityManager;
import jakarta.persistence.PersistenceContext;

import java.util.List;

@Stateless
public class Database {

    @PersistenceContext(unitName="JPADefaultDataBaseConnection")
    private EntityManager em;

    public void addReservation(Reservation rsv) {
        em.persist(rsv);
    }
    
    public List<Reservation> returnReservations() {
        return em.createQuery("SELECT r FROM Reservation r", Reservation.class).getResultList();
    }
    
}
