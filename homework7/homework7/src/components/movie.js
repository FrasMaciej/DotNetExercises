import '../css/movie.css'
import movie from '../images/movie.jpg'


// Komponent odpowiadający pojedyńczemu filmowi
// DO przekazania komponentów zasotosowano destrukturazacje 
function Movie({name, ticketPrice, rate, genre}){
    return(
        <div
        className="movie_box"
        >
            <img
            className='movie_img'
            src={movie}
            />

            <div
            className="movie_name"
            >
                <span>Tytuł: {name}</span>
            </div>

            <div>
                <span>Cena biletu: {ticketPrice} zł</span>
            </div>

            <div>
                <span>Średnia ocen: {rate}</span>
            </div>

            <div>
                <span>Gatunek: {genre}</span>
            </div>
            
        </div>
    );
}

export default Movie;