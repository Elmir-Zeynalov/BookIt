import { useState } from "react";
import CarouselComponent from "./CarouselComponent";


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

    const setImage = (index: number) => {   
        setCurrentImage(index);
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
            <CarouselComponent images={images} currentImage={currentImage} setCurrentImage={setImage} />

      </>
     
  );
}

export default PropertyImageSelector;