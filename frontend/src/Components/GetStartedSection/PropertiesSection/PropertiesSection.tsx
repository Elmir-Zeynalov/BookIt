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
                <div key={index}>
                    <div>WTF</div>
                    <p>{JSON.stringify(property, null, 2)}</p>
                </div>
            ))}

        </>
    );
}

export default PropertiesSection;