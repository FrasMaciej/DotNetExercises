import '../css/App.css';
import Nav from './nav'
import Movie from './movie'

import React, {useState} from "react";

function App() {

  const [movies, setMovies] = useState(
    [
      {
        name: "Uncharted",
        ticketPrice: 20,
        rate: 9,
        genre: "Akcja",
      },

      {
        name: "Doctor Strange",
        ticketPrice: 25,
        rate: 9.2,
        genre: "Akcja",
      },

      {
        name: "Top Gun: Maverick",
        ticketPrice: 20,
        rate: 9.5,
        genre: "Akcja",
      },

      {
        name: "Wiking",
        ticketPrice: 20,
        rate: 8.5,
        genre: "Action",
      },

    ]
  )

  // States odpowiadające inputą do tworzenia
  // nowego filmu
  const [ticketPrice, setTicketPrice] = useState(0);
  const [rate, setRate] = useState(0);
  const [genre, setGenre] = useState("");
  const [name, setName] = useState("");
  


  // Funkcja renderuje wszystkie filmy
  // mapując dane z films i używając komponentu
  // Film do wizualizacji każdego z nich
  const renderMovies = () => {
    return(
      movies.map((movie) => (
        <Movie
        name={movie.name}
        ticketPrice={movie.ticketPrice}
        genre={movie.genre}
        rate={movie.rate}
        />
      ))
    );
  }



  // Funkcja tworzy nowy film 
  // i dodaje go do state'a movies
  const createMovie = () => {
    const movie = {
      name: name,
      rate: rate,
      ticketPrice: ticketPrice,
      genre: genre,
    }

    setMovies([...movies, movie]);
    
    setTicketPrice(0);
    setRate(0);
    setGenre("");
    setName("");
  }

  return (
    <>
      <Nav/>
      <div 
      id="main_box"
      >
        {renderMovies()}
      </div>

      <div
      id="inputs"
      >
        <div>
          <span>Nazwa</span>
          <input
          onChange={(e) => setName(e.target.value)}
          >

          </input>
        </div>
        
        <div>
          <span>Cena</span>
          <input
          onChange={(e) => setTicketPrice(e.target.value)}
          >
          </input>
        </div>
        
        <div>
          <span>Średnia ocen</span>
          <input
          onChange={(e) => setRate(e.target.value)}
          >

          </input>
        </div>
        
        <div>
          <span>Gatunek</span>
          <input
          onChange={(e) => setGenre(e.target.value)}
          >
          </input>
        </div>

        <button
        id="movie_button"
        onClick={(e) => createMovie()}
        >
        Dodaj film
        </button>
      </div>

    </>
  );
}

export default App;
