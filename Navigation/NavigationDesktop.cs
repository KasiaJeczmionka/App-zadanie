@media (min-width: 1025px) {
  .nav {
    width: 20%;
    height: 100%;
    overflow: auto;
    background-color: #09130c;
    color: white;
    display: flex;
    flex-direction: column;
    flex-wrap: nowrap;
    justify-content: space-between;
  }
  .nav__top__logo {
    color: #848a87;
    padding: 2rem;
    padding-bottom: 0rem;
    font-size: 1.5rem;
  }
  .nav__top__logo img {
    margin-right: 1rem;
    width: 1.5rem;
    height: 1.5rem;
  }
  .nav__top__list {
    padding: 2rem;
  }
  .nav__top__list .list {
    padding: 0.5rem;
  }
  .nav__top__list .list img {
    margin-right: 1rem;
    width: 1rem;
    height: 1rem;
  }
  .nav__top__list .list:hover {
    background-color: rgba(255, 255, 255, 0.2);
  }
  .nav__top__list .list[data-is-active=true] {
    background-color: #97f675;
    color: black;
  }
  .nav__end__manage {
    padding: 2rem;
  }
  .nav__end__manage .manage {
    color: #9a9f9c;
    padding-top: 0.5rem;
  }
  .nav__end__manage .manage img {
    width: 1rem;
    height: 1rem;
    margin-right: 1rem;
  }
  .nav__end__account {
    display: grid;
    grid-template-columns: 2rem 1fr;
    grid-template-rows: repeat(2, 1fr);
    grid-column-gap: 0px;
    grid-row-gap: 0px;
    padding: 2rem;
    border-top: 1px solid #131e18;
  }
  .nav__end__account .img {
    grid-area: 1/1/3/2;
    width: 2rem;
    height: 2rem;
    position: relative;
  }
  .nav__end__account .img img {
    height: 100%;
    width: 100%;
    border-radius: 50%;
  }
  .nav__end__account .name {
    grid-area: 1/2/2/3;
    padding-left: 0.5rem;
  }
  .nav__end__account .email {
    grid-area: 2/2/3/3;
    padding-left: 0.5rem;
  }
}

/*# sourceMappingURL=Navigation.cs.map */
