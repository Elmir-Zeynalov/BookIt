



interface CarouselProps {
    images: Array<string>;
    currentImage: number;
    setCurrentImage: (index: number) => void;
}

function CarouselComponent({ images, currentImage, setCurrentImage }: CarouselProps) {
    const numberOfcircles = images.map((image, index) =>
    {
        if (index === currentImage) {
            return <div className="carousel-circle active"></div>
        }
            return <div className="carousel-circle"></div>
    })

    return (
        <div className="carousel-container">
            {numberOfcircles}
        </div>
  );
}

export default CarouselComponent;