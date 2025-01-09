import './GetStarted.css';
import GetStartedMenuItemLogo from "./GetStartedMenuItemLogo";
import GetStartedMenuItemInfo from "./GetStartedMenuItemInfo";
interface GetStartedMenuItemProps {
    className?: string;
    header: string;
    description: string;
}

function GetStartedMenuItem({ className, header, description }: GetStartedMenuItemProps) {
    return (
        <div className={className}>
            <GetStartedMenuItemLogo className="get-started-menu-item-logo" />
            <GetStartedMenuItemInfo
                className="get-started-menu-item-info"
                header={header}
                description={description}
            />
      </div>
  );
}

export default GetStartedMenuItem;