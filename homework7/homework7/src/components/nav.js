import '../css/nav.css'
import movie_logo from '../images/movie_logo.jpg'

function Nav() {
    return(
        <div
        id="nav"
        >
            <img
            id="logo"
            src={movie_logo}
            />

            <h1
            id="header"
            >
                Super Kino!
            </h1>

        </div>
    );
}

export default Nav;