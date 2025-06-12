import React, { useEffect, useState } from 'react';
import './App.css';

function App() {
    const [recipe, setRecipe] = useState(null);

    useEffect(() => {
        fetch('https://localhost:5001/recipe') 
            .then(response => response.json())
            .then(data => setRecipe(data))
            .catch(error => console.error('Error fetching data:', error));
    }, []);

    if (!recipe) {
        return <div className="App">Loading...</div>;
    }

    return (
        <div className="App">
            <h1>{recipe.DishName}</h1>

            <h2>Ingredients</h2>
            <ul>
                {recipe.Ingredients.map((item, index) => (
                    <li key={index}>{item}</li>
                ))}
            </ul>

            <h2>Steps</h2>
            <ol>
                {recipe.Steps.map((step, index) => (
                    <li key={index}>{step}</li>
                ))}
            </ol>
        </div>
    );
}

export default App;

