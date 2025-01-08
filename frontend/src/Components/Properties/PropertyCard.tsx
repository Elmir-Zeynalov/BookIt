import PropertyDetailsButton from "./PropertyDetailsButton";
import PropertyImagesSection from "./PropertyImagesSection";
import PropertyInformation from "./PropertyInformation";
import VerifiedBadge from "./VerifiedBadge";

function PropertyCard() {
    return (
        <>
            <PropertyImagesSection />
            <VerifiedBadge />
            <PropertyInformation />
            <PropertyDetailsButton />
      </>
  );
}

export default PropertyCard;