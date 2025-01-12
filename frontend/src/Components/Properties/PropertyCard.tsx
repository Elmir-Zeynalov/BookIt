
import { Property } from "./types";
import myImage from './0be04875-2131-49b7-ab6e-867378b82f32_IMG_1152.jpeg';
import locationIcon from './location-icon.svg';
import calendarIcon from './calendar-icon.svg';
import walletIcon from './wallet-icon.svg';
import './IconStyles.css';

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
            <div className="property-card-container">
                <div className="property-card-row">
                    <img src={locationIcon} className="property-card-icon" alt="Location Icon" />
                    <p className="property-card-text">{propertyInfo.apartmentLocation}</p>
                </div>
                <div className="property-card-row">
                    <img src={calendarIcon} className="property-card-icon" alt="Calendar Icon" />
                    <p className="property-card-text">{propertyInfo.fromDate} - {propertyInfo.toDate}</p>
                </div>
                <div className="property-card-row">
                    <img src={walletIcon} className="property-card-icon" alt="Wallet Icon" />
                    <p className="property-card-text">{propertyInfo.pricePerNight} / {propertyInfo.pricePerMonth}</p>
                </div>
            </div>
            <button className="property-card-details-button">View Details</button>
        </div>
  );
}

export default PropertyCard;