import PropertyCard from "../../Properties/PropertyCard";
import { Property } from "../../Properties/types";

interface PropertiesSectionProps {
    propertyTitle: string,
    properties: Property[]
}


function PropertiesSection({ propertyTitle, properties }: PropertiesSectionProps) {
    return (
        <>
            <h1>{propertyTitle}</h1>
            {properties.map((property, index) => (
                <PropertyCard
                    key={index}
                    className="property-item-card"
                    propertyInfo={property}
                />
            ))}
        </>
    );
}

export default PropertiesSection;