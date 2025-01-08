
import { Property } from "./types";
import propertyImage from '../../../Images/PropertyImages/0be04875-2131-49b7-ab6e-867378b82f32_IMG_1152.jpeg';
interface PropertyProps {
    className: string,
    propertyInfo: Property;
}


function PropertyCard({ className, propertyInfo }: PropertyProps) {
    return (
        <div style={{ border: "1px solid" }} >
            <img src={`/images/PropertyImages/0e04875-2131-49b7-a6b6-867378b82f32_IMG_1152.jpeg`}   alt="Italian Trulli" />
            <h3>{propertyInfo.apartmentName}</h3>
            <p>{propertyInfo.apartmentLocation}</p>
            <p>{propertyInfo.leasing}</p>
            <p>{propertyInfo.fromDate} - {propertyInfo.toDate}</p>

        </div>
     
  );
}

export default PropertyCard;