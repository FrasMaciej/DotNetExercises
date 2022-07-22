import '../css/App.css';
import Cars from './Cars';
import "antd/dist/antd.css"; 
import React, {useState} from "react";
import CreateCar from './CreateCar';
import { BrowserRouter, Route, Routes, useNavigate } from 'react-router-dom';
import { Menu } from 'antd';

function App() {

  const items = [
    { label: 'Wszystkie samochody', key: 'cars' }, 
    { label: 'Dodaj nowy samochód', key: 'add-car' }
  ];
  const navigate = useNavigate();
  
  const menuClick = (e) => {
    console.log(e);
    const key = e.key;
    switch(key){
      case "cars": navigate("/"); break;
      case "add-car": navigate("create-car"); break;
    }
  };

  return (
    <div className='app'>
      <Menu items={items} onClick={e=>menuClick(e)}></Menu>
      <div className='container'>
          <Routes>
            <Route path='/' element={<Cars></Cars>}></Route>
            <Route path='/create-car' element={<CreateCar />}></Route>
          </Routes>
      </div>
    </div>
  );
}

export default App;
