

import '../css/Car.css';
import Car from './Car';
import React, {useState, useEffect} from "react";

function Cars() {

  const [cars, setCars] = useState([]);

    useEffect(()=>{
        fetch('https://localhost:44377/api/Car',{
        method: "GET"}).then((response)=>response.json()).then((json)=>{
            console.log(json);
            const cars = json.cars;
            setCars(cars);
        })
    }, []);

  return (
      <div 
      id="cars_box"
      >
        {cars.map((car, id)=>{
            return(
            <div className='car' key={id}>        
            <Car
                name={car.name}
                cost={car.cost}
                description={car.description}
            /></div>
            );
        })}
      </div>
  );
}

export default Cars;
