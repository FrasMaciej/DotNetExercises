import '../css/nav.css'
import car_logo from '../images/car_logo.jpg'

function Nav() {
    return(
        <div
        id="nav"
        >
            <img
            id="logo"
            src={car_logo}
            />

            <h1
            id="header"
            >
                Salon samochodowy
            </h1>

        </div>
    );
}

export default Nav;