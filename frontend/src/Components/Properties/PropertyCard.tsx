
import { Property } from "./types";
import myImage from './0be04875-2131-49b7-ab6e-867378b82f32_IMG_1152.jpeg';
import locationIcon from './location-icon.svg';
import calendarIcon from './calendar-icon.svg';
import walletIcon from './wallet-icon.svg';
interface PropertyProps {
    className: string,
    propertyInfo: Property;
}


function PropertyCard({ className, propertyInfo }: PropertyProps) {
    return (
        <div className="property-card" >
            <div className = "property-image-wrapper">
                <img
                    src={myImage}
                    alt="Italian Trulli"
                    className= "property-image"
                />    
            </div>
            
            <h3 className={className}>{propertyInfo.apartmentName}</h3>
            <img src={locationIcon} />  <p> {propertyInfo.apartmentLocation}</p>
            <p>{propertyInfo.leasing}</p>
            <img src={calendarIcon} /><p>{propertyInfo.fromDate} - {propertyInfo.toDate}</p>
            <img src={walletIcon} /> <p>{propertyInfo.pricePerNight} /// {propertyInfo.pricePerMonth} </p>
    
        </div>
     
  );
}

export default PropertyCard;