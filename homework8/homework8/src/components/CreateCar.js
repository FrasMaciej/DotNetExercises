import React, {useState} from "react";
import {useNavigate} from 'react-router-dom'

function CreateCar () {

    const [brand, setBrand] = useState(0);
    const [model, setModel] = useState("");
    const [price, setPrice] = useState("");

    const navigate = useNavigate();

    const createCar = () => {
        const car = {
          brand: brand,
          model: model,
          price: price,
        }

        addCar(car).then(()=>{
            navigate("/");
        })

    }

    const addCar = (car) => {
        return fetch('https://localhost:44377/api/Car',{
            method: "POST",
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json',
            },
            body: JSON.stringify({
                brand: car.brand,
                model: car.model,
                price: parseInt(car.price)
            })})
    }

    return (
        <div
        id="inputs"
        >
          <div>
            <span>Marka</span>
            <input
            onChange={(e) => setBrand(e.target.value)}
            >
  
            </input>
          </div>
          
          <div>
            <span>Model</span>
            <input
            onChange={(e) => setModel(e.target.value)}
            >
            </input>
          </div>
          
          <div>
            <span>Cena</span>
            <input
            onChange={(e) => setPrice(e.target.value)}
            >
  
            </input>
          </div>


          <button
          id="car_button"
          onClick={(e) => createCar()}
          >
          Dodaj samochód
          </button>
        </div>
    )
}
export default CreateCar;