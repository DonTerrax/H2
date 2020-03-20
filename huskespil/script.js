//The querySelectorAll() method returns all elements in the document that matches a specified CSS selector(s), as a static NodeList object.
const cards = document.querySelectorAll('.memory-card');

let hasFlippedCard = false;
let lockBoard = false;
let firstCard, secondCard;
var attemps =0;
let cardFLipped = 0;


function FlipCard() {
    if (lockBoard) return;
    if (this === firstCard) return;

    this.classList.add('flip');

    if (!hasFlippedCard) {
        hasFlippedCard = true;
        firstCard = this;
    }else{
        secondCard = this;
        CheckForMatch();
    }
}

//Checks for a pair on the data-framework name. If there is a pair it calls the disable card function.
//if not it calls the unflip function
function CheckForMatch() {
    let isMatch = firstCard.dataset.framework === secondCard.dataset.framework;
    isMatch ? DisableCards() : UnflipCards();

}
//If a pair has been found it removes them from the eventlistener
function DisableCards() {
    firstCard.removeEventListener('click', FlipCard);
    secondCard.removeEventListener('click', FlipCard);
    cardFLipped +=2;
    if (cardFLipped === 24){
        HasWon();
    }
    resetBoard();
}
//Flips the cards back if it's not a pair by calling the .memory-card.flip and then resets the cards thats
//still in the eventlistener
function UnflipCards() {
    lockBoard = true;
    attemps++;
    ClickAttemps();

    //Creates an anonymous callback function and passes it to setTimeout
    setTimeout(() => {
        firstCard.classList.remove('flip');
        secondCard.classList.remove('flip');
        resetBoard();
    }, 800);
}

function HasWon() {
    setTimeout(() =>{
        alert("You won and you used" + attemps + " attempts");
        RefreshPage();
    },1000);

}
function RefreshPage() {
      location.reload();
}

function resetBoard() {
    hasFlippedCard = false;
    lockBoard = false;
    firstCard = null;
    secondCard = null;

}

function ClickAttemps() {
     document.getElementById('result').innerHTML = 'Attemps: '+ attemps;

}
//Creates a function and invokes/calls it immediately
(function ShuffleCards(){
    cards.forEach(cards =>{
        let randomPos = Math.floor(Math.random() * 24)
        cards.style.order = randomPos;
    });
})();

cards.forEach(card => card.addEventListener('click', FlipCard));