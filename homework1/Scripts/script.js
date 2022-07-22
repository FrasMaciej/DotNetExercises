// to-do -- dodawanie coinów

const oatImg = document.getElementById('oat');
const eggImg = document.getElementById('egg');
const milkImg = document.getElementById('milk');
const honeyImg = document.getElementById('honey');
const barrelImg = document.getElementById('barrel');

const oatButtonElement = document.getElementById('work-oat');
const eggButtonElement = document.getElementById('work-egg');
const milkButtonElement = document.getElementById('work-milk');
const honeyButtonElement = document.getElementById('work-honey');
const barrelButtonElement = document.getElementById('work-barrel');

const buyOatButtonElement = document.getElementById('buy-oat');
const buyEggButtonElement = document.getElementById('buy-egg');
const buyMilkButtonElement = document.getElementById('buy-milk');
const buyHoneyButtonElement = document.getElementById('buy-honey');
const buyBarrelButtonElement = document.getElementById('buy-barrel');

const oatAmountElement = document.getElementById('oat-amount');
const eggAmountElement = document.getElementById('egg-amount');
const milkAmountElement = document.getElementById('milk-amount');
const honeyAmountElement = document.getElementById('honey-amount');
const barrelAmountElement = document.getElementById('barrel-amount');



const coinsElement = document.getElementById('coins');

oatButtonElement.addEventListener('click', work_oat);
eggButtonElement.addEventListener('click', work_egg);
milkButtonElement.addEventListener('click', work_milk);
honeyButtonElement.addEventListener('click', work_honey);
barrelButtonElement.addEventListener('click', work_barrel);

buyOatButtonElement.addEventListener('click', buy_oat);
buyEggButtonElement.addEventListener('click', buy_egg);
buyMilkButtonElement.addEventListener('click', buy_milk);
buyHoneyButtonElement.addEventListener('click', buy_honey);
buyBarrelButtonElement.addEventListener('click', buy_barrel);


setInterval(spin_oat, 20);
setInterval(spin_egg, 20);
setInterval(spin_milk, 20);
setInterval(spin_honey, 20);
setInterval(spin_barrel, 20);

let coins = 10;

let oatAmount = 0;
let eggAmount = 0;
let milkAmount = 0;
let honeyAmount = 0;
let barrelAmount = 0;

//Ustawiam kąt o jaki mają obracać się poszczególne elementy
let degree_oat = 5;
let oat_canRotate = false;

let degree_egg = 4;
let egg_canRotate = false;

let degree_milk = 3;
let milk_canRotate = false;

let degree_honey = 2;
let honey_canRotate = false;

let degree_barrel = 1;
let barrel_canRotate = false;

coinsElement.innerHTML = 'Coins: ' + coins;

// Zdecydowałem się na oddzielne funkcje dla każdego z elementów zamiast przekazywać paramatry, ze względu na problemy z ich poprawnym przesyłaniem
// Prawdopodobnie miało to związek z tym, że wywołuję te funkcje w interwałach. Na ten moment było to dla mnie najprostsze, działające rozwiązanie
function work_oat(){
  if(oatAmount>0){
    document.querySelector('#work-oat').disabled = true;
    oat_canRotate = true;
    spin_oat();
  }
  
}  

function spin_oat(){
  if(oat_canRotate){
    degree_oat += 5;
    if(degree_oat > 355){
      document.querySelector('#work-oat').disabled = false;
      coins+=(1*oatAmount);
      coinsElement.innerHTML = 'Coins: ' + coins;
      degree_oat = 0;
      oat_canRotate = false;
    }
    oatImg.style.transform = 'rotate(' + degree_oat + 'deg)';
  }
}

function work_egg(){
  if(eggAmount>0){
    document.querySelector('#work-egg').disabled = true;
    egg_canRotate = true;
    spin_egg();
  }
  
}

function spin_egg(){
  if(egg_canRotate){
    degree_egg += 4;
    if(degree_egg > 355){
      document.querySelector('#work-egg').disabled = false;
      coins+=(3*eggAmount);
      coinsElement.innerHTML = 'Coins: ' + coins;
      degree_egg = 0;
      egg_canRotate = false;
    }
    eggImg.style.transform = 'rotate(' + degree_egg + 'deg)';
  }
}

function work_milk(){
  if(milkAmount>0){
    document.querySelector('#work-milk').disabled = true;
    milk_canRotate = true;
    spin_milk();
  }
  
}

function spin_milk(){
  if(milk_canRotate){
    degree_milk += 3;
    if(degree_milk > 355){
      document.querySelector('#work-milk').disabled = false;
      coins+=(10*milkAmount);
      coinsElement.innerHTML = 'Coins: ' + coins;
      degree_milk = 0;
      milk_canRotate = false;
    }
    milkImg.style.transform = 'rotate(' + degree_milk + 'deg)';
  }
}

function work_honey(){
  if(honeyAmount>0){
    document.querySelector('#work-honey').disabled = true;
    honey_canRotate = true;
    spin_honey();
  }
  
}

function spin_honey(){
  if(honey_canRotate){
    degree_honey += 2;
    if(degree_honey > 355){
      document.querySelector('#work-honey').disabled = false;
      coins+=(20*honeyAmount);
      coinsElement.innerHTML = 'Coins: ' + coins;
      degree_honey = 0;
      honey_canRotate = false;
    }
    honeyImg.style.transform = 'rotate(' + degree_honey + 'deg)';
  }
}

function work_barrel(){
  if(barrelAmount>0){
    document.querySelector('#work-barrel').disabled = true;
    barrel_canRotate = true;
    spin_barrel();
  }
  
}

function spin_barrel(){
  if(barrel_canRotate){
    degree_barrel += 1;
    if(degree_barrel > 355){
      document.querySelector('#work-barrel').disabled = false;
      coins+=(50*barrelAmount);
      coinsElement.innerHTML = 'Coins: ' + coins;
      degree_barrel = 0;
      barrel_canRotate = false;
    }
    barrelImg.style.transform = 'rotate(' + degree_barrel + 'deg)';
  }
}

function buy_oat(){
  if(coins>=10){
      coins-=10;
      coinsElement.innerHTML = 'Coins: ' + coins;
      oatAmount++;
      oatAmountElement.innerHTML = oatAmount;
  }
}

function buy_egg(){
  if(coins>=30){
    coins-=30;
    coinsElement.innerHTML = 'Coins: ' + coins;
    eggAmount++;
    eggAmountElement.innerHTML = eggAmount;
  }
}

function buy_milk(){
  if(coins>=100){
    coins-=100;
    coinsElement.innerHTML = 'Coins: ' + coins;
    milkAmount++;
    milkAmountElement.innerHTML = milkAmount;
  }
}

function buy_honey(){
  if(coins>=200){
    coins-=200;
    coinsElement.innerHTML = 'Coins: ' + coins;
    honeyAmount++;
    honeyAmountElement.innerHTML = honeyAmount;
  }
}

function buy_barrel(){
  if(coins>=500){
    coins-=500;
    coinsElement.innerHTML = 'Coins: ' + coins;
    barrelAmount++;
    barrelAmountElement.innerHTML = barrelAmount;
  }
}

window.onload = load;
