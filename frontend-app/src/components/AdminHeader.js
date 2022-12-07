import React, {Fragment, useEffect, useState } from "react";
import { useHistory, Link } from "react-router-dom";

export default function AdminHeader(){
    const history = useHistory();

    const [login, setLogin] = useState("");

    useEffect(() => {
        setLogin(localStorage.getItem("login"));
    }, []);

    const logout = (e) => {
        e.preventDefault();
        localStorage.removeItem('login');
        history.push("/");
    }

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
                        <li className="nav-bar active">
                            <a className="nav-link" href="/">
                                Welcome <span className="sr-only">(current)</span>
                                Admin
                            </a>
                        </li>
                        <li className="nav-item">
                            <Link to="/registrationlist" className="nav-link">
                                Registration Management
                            </Link>
                        </li>
                        <li className="nav-item">
                            <Link to="/articlelist" className="nav-link">
                                Article Management
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
    )
}