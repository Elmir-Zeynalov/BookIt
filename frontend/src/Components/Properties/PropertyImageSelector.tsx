import { useState } from "react";


interface PropertyImageSelectorProps {
    images: Array<string>;
}
function PropertyImageSelector({ images }: PropertyImageSelectorProps) {
    const [currentImage, setCurrentImage] = useState(0);


    const nextImage = () => {
        setCurrentImage((currentImage + 1) % images.length);
    }

    const prevImage = () => {
        setCurrentImage((currentImage - 1 + images.length) % images.length);
    }

    return (
      <>
            <img
                src={images[currentImage]}
                alt="Italian Trulli"
                className="property-image"
            />
            <button className="nav-button prev-button" onClick={prevImage}>&lt;</button>
            <button className="nav-button next-button" onClick={nextImage}>&gt;</button>
      </>
     
  );
}

export default PropertyImageSelector;