type GetStartedMenuItemTitleProps = {
    header: string;
};

function GetStartedMenuItemTitle({ header }: GetStartedMenuItemTitleProps) {
    return (
        <p>{header}</p>
    );
}

export default GetStartedMenuItemTitle;