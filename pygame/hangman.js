<!DOCTYPE html>
<html lang="en">
<head>
  <meta charset="UTF-8">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <title>Hangman Game</title>
  <style>
    body {
      font-family: Arial, sans-serif;
    }
  </style>
</head>
<body>

<h1>Hangman Game</h1>
<p id="word-display"></p>
<p id="guesses-left">Guesses left: <span id="remaining-guesses">6</span></p>
<p id="guessed-letters">Guessed letters: <span id="display-guessed-letters"></span></p>
<input type="text" id="user-input" placeholder="Enter your guess">
<button onclick="makeGuess()">Make Guess</button>

<script>
  // List of words for the game
  const words = ["hangman", "javascript", "developer", "programming", "openai", "coding"];

  // Choose a random word from the list
  let selectedWord = words[Math.floor(Math.random() * words.length)];

  // Initialize game state
  let guessedWord = Array(selectedWord.length).fill('_');
  let remainingGuesses = 6;
  let guessedLetters = [];

  // Update the display with the current game state
  function updateDisplay() {
    document.getElementById('word-display').textContent = guessedWord.join(' ');
    document.getElementById('remaining-guesses').textContent = remainingGuesses;
    document.getElementById('display-guessed-letters').textContent = guessedLetters.join(', ');
  }

  // Make a guess
  function makeGuess() {
    let userInput = document.getElementById('user-input').value.toLowerCase();

    // Check if the input is a single letter
    if (userInput.length === 1 && /^[a-zA-Z]+$/.test(userInput)) {
      // Check if the letter has already been guessed
      if (guessedLetters.includes(userInput)) {
        alert('You already guessed that letter. Try again.');
        return;
      }

      // Update guessed letters
      guessedLetters.push(userInput);

      // Check if the letter is in the word
      if (selectedWord.includes(userInput)) {
        for (let i = 0; i < selectedWord.length; i++) {
          if (selectedWord[i] === userInput) {
            guessedWord[i] = userInput;
          }
        }
      } else {
        // Decrement remaining guesses if the letter is not in the word
        remainingGuesses--;
      }

      // Check if the player has won or lost
      if (guessedWord.join('') === selectedWord) {
        alert('Congratulations! You guessed the word: ' + selectedWord);
        resetGame();
      } else if (remainingGuesses === 0) {
        alert('Sorry, you ran out of guesses. The correct word was: ' + selectedWord);
        resetGame();
      }

      // Update the display after each guess
      updateDisplay();
    } else {
      alert('Please enter a valid single letter.');
    }

    // Clear the input field
    document.getElementById('user-input').value = '';
  }

  // Reset the game
  function resetGame() {
    selectedWord = words[Math.floor(Math.random() * words.length)];
    guessedWord = Array(selectedWord.length).fill('_');
    remainingGuesses = 6;
    guessedLetters = [];
    updateDisplay();
  }

  // Initial display setup
  updateDisplay();
</script>

</body>
</html>
