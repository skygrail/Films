import React, { Fragment, useEffect, useState } from "react";
import { useHistory, Link } from "react-router-dom";

export default function UserHeader() {
    const history = useHistory();

    const [login, setLogin] = useState("");

    useEffect(() => {
        setLogin(localStorage.getItem("login"));
    }, []);

    const logout = (e) => {
        e.preventDefault();
        localStorage.removeItem("login");
        history.push("/");
    };

    return (
        <Fragment>
            <nav className="navbar navbar-expand-lg navbar-dark bg-dark">
                <a className="navbar-brand" href="/">
                    Social Network
                </a>
                <button
                    className="navbar-toggler"
                    type="button"
                    data-toggler="collapse"
                    data-target="#navbarSupportedContent"
                    aria-controls="navbarSupportedContent"
                    aria-expanded="false"
                    aria-label="Toggle navigation"
                >
                    <span className="navbar-toggler-icon"></span>
                </button>

                <div className="collapse navbar-collapse" id="navbarSupportedContent">
                    <ul className="navbar-nav mr-auto">
                        <li className="nav-item active">
                            <a className="nav-link" href="/">
                                Welcome <span className="sr-only">(current)</span>
                                {login}
                            </a>
                        </li>
                        <li className="nav-item">
                            <Link to="/userarticle" className="nav-link">
                                Add Article
                            </Link>
                        </li>
                        <li className="nav-item">
                            <Link to="/mynews" className="nav-link">
                                News
                            </Link>
                        </li>
                    </ul>
                    <form className="form-inline my-2 my-lg-0">
                        <button
                            className="btn bnt-outline-success my-2 my-sm-0"
                            type="submit"
                            onClick={(e) => logout(e)}
                        >
                            Logout
                        </button>
                    </form>
                </div>
            </nav>
        </Fragment>
    );
}