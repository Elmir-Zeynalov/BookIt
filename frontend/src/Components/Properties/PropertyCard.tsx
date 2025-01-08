
import { Property } from "./types";

interface PropertyProps {
    className: string,
    propertyInfo: Property;
}


function PropertyCard({ className, propertyInfo }: PropertyProps) {
    return (
        <div style={{ border: "1px solid" }} >
            <h1> IMAGE</h1>
            <h3>{propertyInfo.apartmentName}</h3>
            <p>{propertyInfo.apartmentLocation}</p>
            <p>{propertyInfo.leasing}</p>
            <p>{propertyInfo.fromDate} - {propertyInfo.toDate}</p>

        </div>
     
  );
}

export default PropertyCard;