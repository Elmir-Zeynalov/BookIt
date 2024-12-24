import { useState } from 'react'
function Connect() {
    const [message, setMessage] = useState("");

    const fetchData = async () => {
        try {
            const response = await fetch("http://localhost:8080/HelloWorld");
            if (!response.ok) {
                throw new Error(`HTTP error! status: ${response.status}`);
            }

            const data = await response.text();
            setMessage(data);

        } catch (error) {
            console.error("Error fetching data:", error);
            setMessage("Error fetching data. Please check the console for more information.");
        }
    }
    return (
        <div>
            <button onClick={fetchData}>Connect</button>
            <p>{message}</p>
        </div>
  );
}

export default Connect;