const timeElement = document.getElementById('timer');

updateTimer();

function updateTimer(){
    const date = new Date();
    timeElement.innerHTML = date.toLocaleTimeString();
    setTimeout("updateTimer()", 1000);
  }

  window.onload = load;