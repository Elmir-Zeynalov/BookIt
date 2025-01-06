import React from "react";
import './GetStarted.css';
import GetStartedMenuItemLogo from "./GetStartedMenuItemLogo";
import GetStartedMenuItemInfo from "./GetStartedMenuItemInfo";
interface GetStartedMenuItemProps {
    className?: string;
}

function GetStartedMenuItem({ className }: GetStartedMenuItemProps) {
    return (
        <div className={className}>
            <GetStartedMenuItemLogo />
            <GetStartedMenuItemInfo/>

      </div>
    
  );
}

export default GetStartedMenuItem;