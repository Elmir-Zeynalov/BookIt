import PropertyCard from "./PropertyCard";
import { Property } from "./types";
import './PropertiesStyles.css';
interface PropertiesSectionProps {
    propertyTitle: string,
    properties: Property[]
}


function PropertiesSection({ propertyTitle, properties }: PropertiesSectionProps) {
    return (
        <>
            <h1>{propertyTitle}</h1>
            <div className="property-container">
                {properties.map((property, index) => (
                    <PropertyCard
                        key={index}
                        className="property-item-card"
                        propertyInfo={property}
                    />
                ))}
            </div>

        </>
    );
}

export default PropertiesSection;