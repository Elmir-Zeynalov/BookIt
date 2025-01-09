import './GetStarted.css';

import GetStartedMenuItemDescription from "./GetStartedMenuItemDescription";
import GetStartedMenuItemTitle from "./GetStartedMenuItemTitle";

interface GetStartedMenuItemInfoProps {
    className?: string;
    header: string;
    description: string;
}

function GetStartedMenuItemInfo({ className, header, description }: GetStartedMenuItemInfoProps) {
    return (
        <div className={className}>
            <GetStartedMenuItemTitle header={header} />
            <GetStartedMenuItemDescription description={description} />
      </div>
  );
}

export default GetStartedMenuItemInfo;