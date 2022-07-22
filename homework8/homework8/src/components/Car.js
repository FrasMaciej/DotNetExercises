import '../css/Car.css'
import car from '../images/car.jpg'

function Car({brand,model,price}){
    return(
        <div
        className="car_box"
        >
            <img
            className='car_img'
            src={car}
            />

            <div
            className="car_brand"
            >
                <span>Marka: {brand}</span>
            </div>

            <div>
                <span>Model: {model} </span>
            </div>

            <div>
                <span>Cena: {price}</span>
            </div>
            
        </div>
    );
}

export default Car;