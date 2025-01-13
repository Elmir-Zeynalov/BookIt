interface CarouselProps {
    images: Array<string>;
    currentImage: number;
    setCurrentImage: (index: number) => void;
}

function CarouselComponent({ images, currentImage, setCurrentImage }: CarouselProps) {
    const numberOfCircles = images.map((image, index) => (
        <div key={index} className={`carousel-circle ${index === currentImage ? 'active' : ''}`} onClick={() => setCurrentImage(index)}></div>
    ));

    return (
        <div className="carousel-container">
            {numberOfCircles}
        </div>
  );
}

export default CarouselComponent;